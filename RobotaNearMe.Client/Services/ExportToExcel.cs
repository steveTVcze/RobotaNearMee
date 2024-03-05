using IronXL;
using RobotaNearMe.Lib.Modelos;

namespace RobotaNearMe.Client.Services
{
    public class ExportToExcel
    {
        public void ExportAllUsers(ApiService _service, string companyName)
        {
            List<User> users = _service.GetUsers().ToList();
            WorkBook xlsxWorkbook = WorkBook.Create(ExcelFileFormat.XLSX);
            xlsxWorkbook.Metadata.Author = $"{companyName}";
            WorkSheet xlsSheet = xlsxWorkbook.CreateWorkSheet($"Users");
            xlsSheet["A1"].Value = "First Name";
            xlsSheet["B1"].Value = "Last Name";
            xlsSheet["C1"].Value = "Email";
            xlsSheet["D1"].Value = "Joined";
            xlsSheet["E1"].Value = "LastOnline";

            int i = 2;
            foreach (var item in users)
            {
                xlsSheet[$"A{i}"].Value = $"{item.Name}";
                xlsSheet[$"B{i}"].Value = $"{item.Surname}";
                xlsSheet[$"C{i}"].Value = $"{item.UserName}";
                xlsSheet[$"D{i}"].Value = $"{item.Joined}";
                xlsSheet[$"E{i}"].Value = $"{item.EducationId}";
                xlsSheet[$"E{i}"].Value = $"{item.LastOnline}";
                xlsSheet[$"E{i}"].Value = $"{item.LastOnline}";
                xlsSheet[$"E{i}"].Value = $"{item.LastOnline}";
                xlsSheet[$"E{i}"].Value = $"{item.LastOnline}";
                i += 1;
            }
            for (int x = 1; x < 5; x++)
            {
                xlsSheet.AutoSizeColumn(x);
            }
            xlsSheet.GetRange("A1:E1").Style.BottomBorder.Type = IronXL.Styles.BorderType.Thick;
            xlsSheet.GetRange("A1:E1").Style.ShrinkToFit = true;
            //Update this path when you clone this project from GitLab please.
            string path = $"C:\\Users\\steve\\Downloads\\Users.xlsx";
            xlsxWorkbook.SaveAs(path);
        }
        public void ExportAllCandiates(List<OfferInUser> joboffers, string companyName)
        {
            string documentName = joboffers[0].JobOffer.Title;
            WorkBook xlsxWorkbook = WorkBook.Create(ExcelFileFormat.XLSX);
            xlsxWorkbook.Metadata.Author = $"{companyName}";
            WorkSheet xlsSheet = xlsxWorkbook.CreateWorkSheet($"{documentName}");
            xlsSheet["A1"].Value = "First Name";
            xlsSheet["B1"].Value = "Last Name";
            xlsSheet["C1"].Value = "Username";
            xlsSheet["D1"].Value = "Joined";
            xlsSheet["E1"].Value = "LastOnline";
            xlsSheet["F1"].Value = "School Name";
            xlsSheet["G1"].Value = "Max Education Level Id";
            xlsSheet["H1"].Value = "School Address";
            xlsSheet["I1"].Value = "Address";
            xlsSheet["J1"].Value = "City";
            xlsSheet["K1"].Value = "Postal Code";
            xlsSheet["L1"].Value = "Country";
            xlsSheet["M1"].Value = "Email";
            xlsSheet["N1"].Value = "Phone";
            xlsSheet["O1"].Value = "Date of appliance";
            int i = 2;
            foreach (var item in joboffers)
            {
                xlsSheet[$"A{i}"].Value = $"{item.User.Name}";
                xlsSheet[$"B{i}"].Value = $"{item.User.Surname}";
                xlsSheet[$"C{i}"].Value = $"{item.User.UserName}";
                xlsSheet[$"D{i}"].Value = $"{item.User.Joined}";
                xlsSheet[$"E{i}"].Value = $"{item.User.LastOnline}";
                xlsSheet[$"F{i}"].Value = $"{item.User.Education.SchoolName}";
                xlsSheet[$"G{i}"].Value = $"{item.User.Education.MaxEduLevelId}";
                xlsSheet[$"H{i}"].Value = $"{item.User.Education.SchoolAddress}";
                xlsSheet[$"I{i}"].Value = $"{item.User.Contact.Address}";
                xlsSheet[$"J{i}"].Value = $"{item.User.Contact.City}";
                xlsSheet[$"K{i}"].Value = $"{item.User.Contact.Postal}";
                xlsSheet[$"L{i}"].Value = $"{item.User.Contact.Country}";
                xlsSheet[$"M{i}"].Value = $"{item.User.Contact.Email}";
                xlsSheet[$"N{i}"].Value = $"{item.User.Contact.Phone}";
                xlsSheet[$"O{i}"].Value = $"{item.AddedAt}";
                i += 1;
            }
            for (int x = 1; x < 15; x++)
            {
                xlsSheet.AutoSizeColumn(x);
            }
            xlsSheet.GetRange("A1:O1").Style.BottomBorder.Type = IronXL.Styles.BorderType.Thick;
            xlsSheet.GetRange("A1:O1").Style.ShrinkToFit = true;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string filePath = Path.Combine(path, documentName +".xlsx");
            string pathos = $"C:\\Users\\steve\\Downloads\\Users.xlsx";
            xlsxWorkbook.SaveAs(filePath);
        }
    }
}
