using IronSoftware;
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
            //we get a list of users and we create a new file called users.pdf - then we create a new table and insert the values from the list to it
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
    }
}
