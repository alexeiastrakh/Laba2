using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Conferences
{
     class LinqToXML:IStrategy
    {
        
        public List<Events> AnalyzeFile(Events events)
        {
            List<Events> find = new List<Events>();
            var doc = XDocument.Load(@"D:\EventsDota\EventsDota\bin\Debug\EventsDataBase.xml");
            var res = from mySearch in doc.Descendants("Event")
                      where 
                      (mySearch.Attribute("NAME").Value.Equals(events.Name) || events.Name.Equals(String.Empty)) &&
                      (mySearch.Attribute("START").Value.Equals(events.StartDate) || events.StartDate.Equals(String.Empty)) &&
                      (mySearch.Attribute("END").Value.Equals(events.EndDate) || events.EndDate.Equals(String.Empty)) &&
                      (mySearch.Attribute("LOCATION").Value.Equals(events.Location) || events.Location.Equals(String.Empty)) &&
                      (mySearch.Attribute("FACULTY").Value.Equals(events.Faculty) || events.Faculty.Equals(String.Empty)) &&
                      (mySearch.Attribute("PARTICIPATIONPRICE").Value.Equals(events.Participationprice) || events.Participationprice.Equals(String.Empty)) &&
                      (mySearch.Attribute("RESPONSIBLEPERSON").Value.Equals(events.Responsibleperson) || events.Responsibleperson.Equals(String.Empty)) 
                      
                      select new
                      {
                         
                          name = (string)mySearch.Attribute("NAME"),
                          start = (string)mySearch.Attribute("START"),
                          end = (string)mySearch.Attribute("END"),
                          Location = (sring)mySearch.Attribute("LOCATION"),
                          Faculty = (string)mySearch.Attribute("FACULTY"),
                          Participationprice = (string)mySearch.Attribute("PARTICIPATIONPRICE"),
                          Responsibleperson = (string)mySearch.Attribute("RESPONSIBLEPERSON"),
                         
                      };
            foreach(var match in res)
            {
                Events ev = new Events();
                
                ev.Name = match.name;
                ev.StartDate = match.start;
                ev.EndDate = match.end;
                ev.Location = match.location;
                ev.Faculty = match.Faculty;
                ev.Participationprice = match.Participationprice;
                ev.Responsibleperson = match.Responsibleperson;
          
                find.Add(ev);
            }
            return find;
        }
    }
}
