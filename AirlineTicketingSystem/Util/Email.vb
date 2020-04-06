Public Class Email
	Public Shared ServerEmail As String

	'@ Reference Nick @ https://stackoverflow.com/questions/18153542/how-do-i-send-a-gmail-email-in-vb-net
	Public Shared Sub Send(subject As String, body As String, recipientEmail As String)
		Dim email As New Net.Mail.MailMessage
		Dim SMTP As New Net.Mail.SmtpClient("smtp.gmail.com")

		email.Subject = subject
		email.IsBodyHtml = True
		email.Body = body
		email.From = New Net.Mail.MailAddress(ServerEmail)
		SMTP.Credentials = New Net.NetworkCredential("aozorairlines@gmail.com", "aozora123")

		email.To.Add(recipientEmail)

		SMTP.EnableSsl = True
		SMTP.Port = "587"

		SMTP.Send(email)
	End Sub
End Class
