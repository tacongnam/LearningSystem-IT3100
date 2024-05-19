namespace Learning_System.ProcessingClasses
{
    public class E01CantFindFile : Exception
    {
        public E01CantFindFile() : base("[E01] Can't get information from destination file. Your file may not found in selected folder or be broken!") { }
        public E01CantFindFile(string path) : base("[E01] Can't get information from " + path + ". Your file may not found in selected folder or be broken!") { }
    }

    public class E02CantProcessQuery : Exception
    {
        public E02CantProcessQuery() : base("[E02] Can't get data. Columns, queries or sorts may be not correct or your file doesn't have these elements.") { }
    }

    public class E03NotExistColumn : Exception
    {
        public E03NotExistColumn(string column) : base("[E03] Can't process " + column + ". Your column name may be not correct!") { }
    }

    public class E04CantExportProperly : Exception
    {
        public E04CantExportProperly() { }
        public E04CantExportProperly(string path) : base("[E04] Can't export data to " + path + ". Check your path and exported data again.") { }
    }

    public class E05CantInsertProperly : Exception
    {
        public E05CantInsertProperly() : base("[E05] Can't insert data to DataTable. Check your data again.") { }
    }

    public class E99OtherException : Exception
    {
        public E99OtherException() { }
        public E99OtherException(string message) : base("[E99] Something got error.\nDescription:" + message) { }
    }
}
