namespace ImportTools
{
    internal class EntityCell
    {
        public string Field { get; set; }

        public bool IsNullable { get; set; }

        public EntityCell(string field, bool isNullable = false)
        {
            Field = field;
            IsNullable = isNullable;
        }
    }
}