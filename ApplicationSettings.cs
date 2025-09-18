namespace AssessmentPortal
{
    class ApplicationSettings
    {
        public static string ConnectionString
        {
          get  
            {
                return @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=assessmentportal; Integrated Security=true";
            }
        }
    }
}
