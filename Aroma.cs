// Aroma.cs
namespace ProyekParfum
{
    public class Aroma
    {
        public string TopNote { get; private set; }
        public string MiddleNote { get; private set; }
        public string BaseNote { get; private set; }

        // CONSTRUCTOR
        public Aroma(string topNote, string middleNote, string baseNote)
        {
            TopNote = topNote;
            MiddleNote = middleNote;
            BaseNote = baseNote;
        }

        public void TampilkanAroma()
        {
            Console.WriteLine($"  - Top Note: {TopNote}");
            Console.WriteLine($"  - Middle Note: {MiddleNote}");
            Console.WriteLine($"  - Base Note: {BaseNote}");
        }
    }
}