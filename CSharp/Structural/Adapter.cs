namespace DesignPatterns.Structural
{
    /*
     * IXmlData is the existing (legacy) interface, and LegacyXmlData is its implementation.
     * IJsonData is the new interface that the modern application uses.
     * XmlToJsonAdapter is the adapter that implements IJsonData and translates the XML from IXmlData to JSON.
     */

    // Existing Interface (XML)
    public interface IXmlData
    {
        string GetXml();
    }

    // Concrete Implementation of Existing Interface
    public class LegacyXmlData : IXmlData
    {
        public string GetXml()
        {
            return "<data>Hello from XML</data>";
        }
    }

    // New Interface (JSON)
    public interface IJsonData
    {
        string GetJson();
    }

    // Adapter
    public class XmlToJsonAdapter : IJsonData
    {
        private IXmlData _xmlData;

        public XmlToJsonAdapter(IXmlData xmlData)
        {
            _xmlData = xmlData;
        }

        public string GetJson()
        {
            var xml = _xmlData.GetXml();
            // Simulate XML to JSON conversion
            return $"{{ 'data': '{xml.Replace("<data>", "").Replace("</data>", "")}' }}";
        }
    }
}
