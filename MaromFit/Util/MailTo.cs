using MaromFit.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace MaromFit.Util
{
    public class MailTo
    {
        public bool SendMail(Mail mail)
        {
            // Estancia da Classe de Mensagem
            MailMessage _mailMessage = new MailMessage();

            // Remetente
            _mailMessage.From = new MailAddress("SeuEmail@.blablabla.com");

            // Destinatario seta no metodo abaixo
            _mailMessage.CC.Add("SeuEmail@.blablabla.com");

            //Contrói o MailMessage
            string html = @"
                <div class='row'>
        <div class='col-md-12'>
            <div class='jumbotron'>
                <h3>[Subject]</h3>
                <br />
                [Message]
            </div>
        </div>

        <div class='col-md-12'>
            <hr />
            <b>Nome: </b>[Name]
            <br />
            <b>Email: </b>[Mail]
        </div>";

            html = html.Replace("[Name]", mail.Name);
            html = html.Replace("[Mail]", mail.UserMail);
            html = html.Replace("[Subject]", mail.Subject);
            html = html.Replace("[Message]", mail.Message);

            // Assunto
            _mailMessage.Subject = mail.Subject;
            // A mensagem é do tipo HTML ou Texto Puro?
            _mailMessage.IsBodyHtml = true;
            _mailMessage.Body = html;

            //CONFIGURAÇÃO COM PORTA
            SmtpClient _smtpClient = new SmtpClient("smtp.gmail.com", 587);

            //CONFIGURAÇÃO SEM PORTA
            // SmtpClient _smtpClient = new SmtpClient(SMTP);

            // Credencial para envio por SMTP Seguro (Quando o servidor exige autenticação)
            _smtpClient.UseDefaultCredentials = false;
            _smtpClient.Credentials = new NetworkCredential("SeuEmail@.blablabla.com", "SUA SENHA");

            _smtpClient.EnableSsl = true;

            _smtpClient.Send(_mailMessage);

            return true;
        }
    }
}