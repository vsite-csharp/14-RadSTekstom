namespace Vsite.CSharp.RadSTekstom
{
    // primjer kako funkcioniraju metode sa znakovnim nizovima
    static class Program
    {
        // TODO:020 Pogledati donji kod i provjeriti što će se ispisati njegovim izvođenjem
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string oružje = "katapult";
            string pojam = oružje.Remove(1, 4);

            Console.WriteLine($"oružje = {oružje}");
            Console.WriteLine($"pojam = {pojam}");

            Console.WriteLine();

            string sat = pojam.Insert(pojam.Length, "ura");
            Console.WriteLine($"pojam = {pojam}");
            Console.WriteLine($"sat = {sat}");

            Console.WriteLine("\nGOTOVO!!!");
        }
    }
}
