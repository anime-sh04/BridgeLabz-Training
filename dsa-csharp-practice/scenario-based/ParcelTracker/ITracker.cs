namespace ParcelTracker
{
    interface ITracker
    {
        void AddStage(string stage);
        void AddCheckpoint(string afterStage, string checkpoint);
        void Display();
        void MarkLost();
    }
}
