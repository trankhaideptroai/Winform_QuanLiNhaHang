using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI
{
    public partial class FQuenMK : Form
    {
        private Random random = new Random();
        public FQuenMK()
        {
            InitializeComponent();
        }
        public string GetPassword()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4, true));
            builder.Append(random.Next(1000, 9999));
            builder.Append(RandomString(2, false));
            return builder.ToString();
        }

        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            char offset = lowerCase ? 'a' : 'A';
            for (int i = 0; i < size; i++)
            {
                char ch = (char)(random.Next(26) + offset);
                builder.Append(ch);
            }
            return builder.ToString();
        }

        private string EncryptPassword(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] encryptedBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in encryptedBytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }


        private void SendEmail(string toEmail, string newPassword)
        {
            string fromEmail = "khaittps40102@gmail.com";
            string fromPassword = "nwtf nzqp tqmk ogow";

            SmtpClient client = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromEmail, fromPassword),
                EnableSsl = true,
            };

            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress(fromEmail),
                Subject = "Password Recovery",
                Body = $"Your new password is: {newPassword}",
                IsBodyHtml = false,
            };
            mailMessage.To.Add(toEmail);

            try
            {
                client.Send(mailMessage);
                MessageBox.Show("Password has been sent to your email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(newPassword);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FLogin login = new FLogin();
            login.Show();
        }

        private void btn_laymk_Click(object sender, EventArgs e)
        {
            string email = txt_email_quenmk.Text; // Assuming you have a TextBox named txt_email_quenmk for inputting the email address
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string newPassword = GetPassword();
            SendEmail(email, newPassword);

            // Mã hóa mật khẩu trước khi cập nhật trong cơ sở dữ liệu
            string encryptedPassword = EncryptPassword(newPassword);
            UpdatePasswordInDatabase(email, encryptedPassword);
        }
        private void UpdatePasswordInDatabase(string email, string encryptedPassword)
        {
            string connectionString = @"Data Source=DESKTOP-6P7HGD3;Initial Catalog=qlnhahang;Integrated Security=True"; // Replace with your actual connection string

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE NhanVien SET MatKhau = @MatKhau WHERE Email = @Email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MatKhau", encryptedPassword);
                    command.Parameters.AddWithValue("@Email", email);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Email not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating password: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
