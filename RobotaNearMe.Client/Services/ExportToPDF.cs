using IronSoftware;
using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RobotaNearMe.Lib.Modelos;

namespace RobotaNearMe.Client.Services
{
    public class ExportToPDF
    {
        public void ExportAllUsers(ApiService _service)
        {
            List<User> users = _service.GetUsers().ToList();
            PdfWriter writer = new PdfWriter("Users.pdf");
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            iText.Layout.Element.Table table = new iText.Layout.Element.Table(users.Count);

            for (int i = 0; i < users.Count; i++)
            {
                table.AddHeaderCell($"{users[i].UserName}");
            }
            for (int i = 0; i < users.Count; i++)
            {
                table.AddCell("Name : " + users[i].Name);
            }
            for (int i = 0; i < users.Count; i++)
            {
                table.AddCell("Surname : " + users[i].Surname);
            }
            for (int i = 0; i < users.Count; i++)
            {
                table.AddCell("Joined : " + users[i].Joined.ToString());
            }

            document.Add(table);

            document.Close();
        }
        public void ExportJobOffer(JobOffer _offer)
        {
            PdfWriter writer = new PdfWriter($"JobOffer{_offer.Title}.pdf");
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);
            PdfFont font = PdfFontFactory.CreateFont("C:\\Users\\steve\\source\\repos\\RobotaNearMee\\RobotaNearMe.Client\\Fonts\\Amatic-Bold.ttf", PdfEncodings.IDENTITY_H);
            float fontSize = 22.0f; 

            iText.Layout.Element.Table table = new iText.Layout.Element.Table(1).SetFont(font).SetFontSize(fontSize);

            table.AddHeaderCell($"{_offer.Title}");
            table.AddCell("Salary : " + _offer.Salary);
            table.AddCell("Id : " + _offer.Id);
            table.AddCell("Benefits : " + _offer.Benefits);
            table.AddCell("Description : " + _offer.Description);
            table.AddCell("Added : " + _offer.Added);
            table.AddCell("CompanyId : " + _offer.CompanyId);
            table.AddCell("Language : " + _offer.Language);
            table.AddCell("Remote : " + _offer.Remote);
            table.AddCell("StillValid : " + _offer.StillValid);
            table.AddCell("JobTypeId : " + _offer.JobTypeId);
            table.AddCell("JobFieldId : " + _offer.JobFieldId);
            table.AddCell("LastUpdated : " + _offer.LastUpdated);
            table.AddCell("Region : " + _offer.LocationId);
            document.Add(table);

            document.Close();
        }
    }
}
