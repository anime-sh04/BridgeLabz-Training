namespace ParcelTracker
{
    class ParcelNode
    {
        public string Stage;
        public ParcelNode Next;

        public ParcelNode(string stage)
        {
            Stage = stage;
            Next = null;
        }
    }
}