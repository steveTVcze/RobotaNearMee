using IronSoftware;
using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RobotaNearMe.Lib.Modelos;
using System;

namespace RobotaNearMe.Client.Services
{
    public class ExportToPDF
    {
        public void ExportAllUsersThatAppliedForJob(List<OfferInUser> joboffers, string companyName)
        {
            string fileName = joboffers[0].JobOffer.Title;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string filePath = System.IO.Path.Combine(path, fileName);
            PdfWriter writer = new PdfWriter($"{filePath}.pdf");
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf, PageSize.A4);
            document.SetMargins(36, 36, 36, 36);
            PdfFont font = PdfFontFactory.CreateFont("C:\\Users\\steve\\source\\repos\\RobotaNearMee\\RobotaNearMe.Client\\Fonts\\Amatic-Bold.ttf", PdfEncodings.IDENTITY_H);
            float fontSize = 7.0f;

            //iText.Layout.Element.Table table = new iText.Layout.Element.Table(joboffers.Count).SetFont(font).SetFontSize(fontSize);
            document.Add(new Paragraph($"Applicants for Job Offer - {fileName}").SetFont(font).SetFontSize(fontSize));

            iText.Layout.Element.Table table = new iText.Layout.Element.Table(14, false);
            table.AddCell("First Name").SetFont(font).SetFontSize(fontSize);
            table.AddCell("Last Name").SetFont(font).SetFontSize(fontSize);
            table.AddCell("Joined").SetFont(font).SetFontSize(fontSize);
            table.AddCell("Last Online").SetFont(font).SetFontSize(fontSize);
            table.AddCell("School Name").SetFont(font).SetFontSize(fontSize);
            table.AddCell("Max Edu Level Id").SetFont(font).SetFontSize(fontSize);
            table.AddCell("School Address").SetFont(font).SetFontSize(fontSize);
            table.AddCell("Contact Address").SetFont(font).SetFontSize(fontSize);
            table.AddCell("Contact city").SetFont(font).SetFontSize(fontSize);
            table.AddCell("Contact postal").SetFont(font).SetFontSize(fontSize);
            table.AddCell("Contact country").SetFont(font).SetFontSize(fontSize);
            table.AddCell("Contact Email").SetFont(font).SetFontSize(fontSize);
            table.AddCell("Contact phone").SetFont(font).SetFontSize(fontSize);
            table.AddCell("Date of appliance").SetFont(font).SetFontSize(fontSize);


            foreach (var useros in joboffers)
            {
                table.AddCell(useros.User.Name);
                table.AddCell(useros.User.Surname);
                table.AddCell(useros.User.Joined.ToString());
                table.AddCell(useros.User.LastOnline.ToString());
                table.AddCell(useros.User.Education.SchoolName);
                table.AddCell(useros.User.Education.MaxEduLevelId.ToString());
                table.AddCell(useros.User.Education.SchoolAddress);
                table.AddCell(useros.User.Contact.Address);
                table.AddCell(useros.User.Contact.City);
                table.AddCell(useros.User.Contact.Postal);
                table.AddCell(useros.User.Contact.Country);
                table.AddCell(useros.User.Contact.Email);
                table.AddCell(useros.User.Contact.Phone);
                table.AddCell(useros.AddedAt.ToString());
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
