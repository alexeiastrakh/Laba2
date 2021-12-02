using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Conferences
{
    class SAX:IStrategy
    {
        public List<Events> AnalyzeFile(Events events)
        {
            List<Events> find = new List<Events>();
            var xmlReader = new XmlTextReader((@"D:\EventsDota\EventsDota\bin\Debug\EventsDataBase.xml"));

            while (xmlReader.Read())
            {
                if (xmlReader.HasAttributes)
                {
                    while (xmlReader.MoveToNextAttribute())
                    {
                       
                        string Name = "";
                        string StartDate = "";
                        string EndDate = "";
                        string Location = "";
                        string City = "";
                        string Participationprice = "";
                        string Responsibleperson = "";
                       

                      
                            if (xmlReader.Name.Equals("NAME") && (xmlReader.Value.Equals(events.Name) || events.Name.Equals(String.Empty)))
                            {
                                Name = xmlReader.Value;
                                xmlReader.MoveToNextAttribute();

                                if (xmlReader.Name.Equals("START") && (xmlReader.Value.Equals(events.StartDate) || events.StartDate.Equals(String.Empty)))
                                {
                                    StartDate = xmlReader.Value;
                                    xmlReader.MoveToNextAttribute();
                                    if (xmlReader.Name.Equals("END") && (xmlReader.Value.Equals(events.EndDate) || events.EndDate.Equals(String.Empty)))
                                    {
                                        EndDate = xmlReader.Value;
                                        xmlReader.MoveToNextAttribute();
                                        if (xmlReader.Name.Equals("LOCATION") && (xmlReader.Value.Equals(events.Location) || events.Location.Equals(String.Empty)))
                                        {
                                            Location = xmlReader.Value;
                                            xmlReader.MoveToNextAttribute();
                                            if (xmlReader.Name.Equals("FACULTY") && (xmlReader.Value.Equals(events.Faculty) || events.Faculty.Equals(String.Empty)))
                                            {
                                                City = xmlReader.Value;
                                                xmlReader.MoveToNextAttribute();
                                                if (xmlReader.Name.Equals("PARTICIPATIONPRICE") && (xmlReader.Value.Equals(events.Participationprice) || events.Participationprice.Equals(String.Empty)))
                                                {
                                                    Participationprice = xmlReader.Value;
                                                    xmlReader.MoveToNextAttribute();
                                                    if (xmlReader.Name.Equals("RESPONSIBLEPERSON") && (xmlReader.Value.Equals(events.Responsibleperson) || events.Responsibleperson.Equals(String.Empty)))
                                                    {
                                                        Responsibleperson = xmlReader.Value;
                                                        xmlReader.MoveToNextAttribute();
                                                       
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                
                            
                        

                        if ( Name != "" && StartDate != "" && EndDate != "" && Location != "" && && Participationprice != "" && Responsibleperson != "")
                            
                        {
                            Events ev = new Events();
                          
                            ev.Name = Name;
                            ev.StartDate = StartDate;
                            ev.EndDate = EndDate;
                            ev.Location = Location;
                            ev.Faculty = Faculty;
                            ev.Participationprice = Participationprice;
                            ev.Responsibleperson = Responsibleperson;
                          

                            find.Add(ev);
                        }

                    }
                }
            }

            xmlReader.Close();
            return find;
        }
    }
}
