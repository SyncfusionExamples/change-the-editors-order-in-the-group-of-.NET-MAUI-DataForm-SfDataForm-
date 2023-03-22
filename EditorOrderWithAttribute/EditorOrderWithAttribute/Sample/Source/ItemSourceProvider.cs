using Syncfusion.Maui.DataForm;

namespace EditorOrderWithAttribute
{
    public class ItemSourceProvider : IDataFormSourceProvider
    {
        public object GetSource(string sourceName)
        {
            if (sourceName == "Degree")
            {
                List<string> country = new List<string>() { "BE", "B.Tech", "BCA", "MCA" };
                return country;
            }

            if (sourceName == "Branch")
            {
                List<string> city = new List<string>() { "Computer Science", "Information Technology" };
                return city;
            }

            return new List<string>();
        }
    }
}