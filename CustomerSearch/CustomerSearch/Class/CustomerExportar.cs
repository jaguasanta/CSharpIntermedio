using System;

namespace CustomerSearch.Class
{
    public abstract class CustomerExportar
    {
        public CustomerExportar()
        {
            
        }

        public abstract void ExportarCSV();

        public abstract void ExportarXML();

        public abstract void ExportarPDF();

    }
}
