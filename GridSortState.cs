using System.ComponentModel;

namespace sellular_shop.Sorting
{
    public class GridSortState
    {
        private string _lastSortedColumnName;
        private ListSortDirection _lastSortDirection = ListSortDirection.Ascending;

        public ListSortDirection GetNextDirection(string dataPropertyName)
        {
            ListSortDirection nextSortDirection = ListSortDirection.Ascending;

            if (_lastSortedColumnName == dataPropertyName)
            {
                nextSortDirection = _lastSortDirection == ListSortDirection.Ascending
                    ? ListSortDirection.Descending
                    : ListSortDirection.Ascending;
            }

            _lastSortedColumnName = dataPropertyName;
            _lastSortDirection = nextSortDirection;
            return nextSortDirection;
        }

        public void Reset()
        {
            _lastSortedColumnName = null;
            _lastSortDirection = ListSortDirection.Ascending;
        }

        public static string ToSortDirectionText(ListSortDirection direction)
        {
            return direction == ListSortDirection.Ascending ? "ASC" : "DESC";
        }
    }
}
