namespace LibrairieConversionNote
{
    public static class ConversionAlphabetiqueToNote
    {
        public static string Transform(string note)
        {   
            if (note == "A")
            {
                return "LA";
            }
            else if (note == "B")
            {
                return "SI";
            }
            else if (note == "C")
            {
                return "DO";
            }
            else if (note == "D")
            {
                return "RE";
            }
            else if (note == "E")
            {
                return "MI";
            }
            else if (note == "F")
            {
                return "FA";
            }
            else if (note == "G")
            {
                return "SOL";
            }
            else
            {
                return "ERREUR! CETTE NOTE N'EXISTE PAS";
            }
        }
    }
}