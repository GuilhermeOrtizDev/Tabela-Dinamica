namespace Web
{
    public class TableVO
    {
        public Type? Model { get; set; }

        public dynamic? Items { get; set; }

        public List<Actions>? Actions { get; set; }

        public TableVO()
        {
            Actions = new List<Actions>();
        }
    }
}

public enum Actions : short
{
    Detail = 1,
    Edit = 2,
    Delete = 3
}
