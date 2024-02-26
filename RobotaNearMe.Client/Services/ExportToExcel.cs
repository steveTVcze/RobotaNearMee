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
    }
}
