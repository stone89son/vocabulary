using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Tip.Models;

namespace Tip.Entities
{
    public class DataStore
    {
            
            //Get All
            public List<DataStoreModel> GetAll()
            {

                try
                {
                    XDocument xmlDoc = XDocument.Load(Config.dataStoreFile);
                    var matchMatchings = from c in xmlDoc.Elements("DocumentElement").Descendants("Entity")
                                            select new DataStoreModel
                                            {
                                                Id = (string)c.Element("Id") != null ? (string)c.Element("Id").Value : "",
                                                Japanese = (string)c.Element("Japanese") != null ? (string)c.Element("Japanese").Value : "",
                                                Pronounce = (string)c.Element("Pronounce") != null ? (string)c.Element("Pronounce").Value : "",
                                                Mean = (string)c.Element("Mean") != null ? (string)c.Element("Mean").Value : "",
                                                Genre = (string)c.Element("Genre") != null ? (string)c.Element("Genre").Value : "",
                                                Example = (string)c.Element("Example") != null ? (string)c.Element("Example").Value : "",
                                                Speak = (string)c.Element("Speak") != null ? (string)c.Element("Speak").Value : "",
                                                Date = (string)c.Element("Date") != null ? (string)c.Element("Date").Value : "",
                                                Picture = (string)c.Element("Picture") != null ? (string)c.Element("Picture").Value : ""
                                            };
                    return matchMatchings.ToList();
                }
                catch
                {
                    return null;
                }
            }

            //Get by Date
            public List<DataStoreModel> GetByDate(DateTime dateStart,DateTime dateEnd)
            {

                try
                {
                    XDocument xmlDoc = XDocument.Load(Config.dataStoreFile);
                       CultureInfo provider = CultureInfo.InvariantCulture;
                       var matchMatchings = from c in xmlDoc.Elements("DocumentElement").Descendants("Entity").AsEnumerable().Where(e => DateTime.ParseExact(e.Element("Date").Value, "dd/MM/yyyy", provider) >= dateStart).Where(e => DateTime.ParseExact(e.Element("Date").Value, "dd/MM/yyyy", provider) <= dateEnd)
                                         select new DataStoreModel
                                         {


                                             Id = (string)c.Element("Id") != null ? (string)c.Element("Id").Value : "",
                                             Japanese = (string)c.Element("Japanese") != null ? (string)c.Element("Japanese").Value : "",
                                             Pronounce = (string)c.Element("Pronounce") != null ? (string)c.Element("Pronounce").Value : "",
                                             Mean = (string)c.Element("Mean") != null ? (string)c.Element("Mean").Value : "",
                                             Genre = (string)c.Element("Genre") != null ? (string)c.Element("Genre").Value : "",
                                             Example = (string)c.Element("Example") != null ? (string)c.Element("Example").Value : "",
                                             Speak = (string)c.Element("Speak") != null ? (string)c.Element("Speak").Value : "",
                                             Date = (string)c.Element("Date") != null ? (string)c.Element("Date").Value : "",
                                             Picture = (string)c.Element("Picture") != null ? (string)c.Element("Picture").Value : ""
                                         };
                    return matchMatchings.ToList();
                }
                catch
                {
                    return null;
                }
            }
            public void AddByList(List<DataStoreModel> siEntities) {
                try
                {
                    var doc = XDocument.Load(Config.dataStoreFile);

                    foreach (var siEntity in siEntities)
                    {
                        var batchmatching =
                             new XElement("Entity",
                             new XElement("Id", siEntity.Id),
                             new XElement("Japanese", siEntity.Japanese),
                             new XElement("Pronounce", siEntity.Pronounce),
                             new XElement("Mean", siEntity.Mean),
                             new XElement("Genre", siEntity.Genre),
                             new XElement("Example", siEntity.Example),
                             new XElement("Speak", siEntity.Speak),
                             new XElement("Date", siEntity.Date),
                             new XElement("Picture", siEntity.Picture)
                         );
                        doc.Element("DocumentElement").Add(batchmatching);
                        doc.Save(Config.dataStoreFile);
                    }
                }
                catch (Exception)
                {

                }//Bỏ qua các giá trị lỗi như NULL...
            }
            //Add
            public void Add(DataStoreModel siEntity) //Add
            {
                try
                {
                    var doc = XDocument.Load(Config.dataStoreFile);

                    var batchmatching =
                            new XElement("Entity",

                            new XElement("Id", siEntity.Id),  
                            new XElement("Japanese", siEntity.Japanese),
                            new XElement("Pronounce", siEntity.Pronounce),
                            new XElement("Mean", siEntity.Mean),
                            new XElement("Genre", siEntity.Genre),
                            new XElement("Example", siEntity.Example),
                            new XElement("Speak", siEntity.Speak),
                            new XElement("Date", siEntity.Date),
                            new XElement("Picture", siEntity.Picture)
                            

                        );
                    doc.Element("DocumentElement").Add(batchmatching);
                    doc.Save(Config.dataStoreFile);

                }
                catch (Exception)
                {

                }//Bỏ qua các giá trị lỗi như NULL...
            }
            //Del
            public bool Delete(string Id)
            {
                try
                {
                    var doc = XDocument.Load(Config.dataStoreFile);
                    doc.Elements("DocumentElement").Elements("Entity").Where(x => x.Element("Id").Value == Id).Remove();
                    doc.Save(Config.dataStoreFile);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }

            }
            //Edit
            public bool Update(string Id, DataStoreModel siModel)
            {
                try
                {

                    var doc = XDocument.Load(Config.dataStoreFile);
                    var siNode = doc.Elements("DocumentElement").Elements("Entity").Where(x => x.Element("Id").Value == Id.Trim()).Take(1);
                    if (siModel.Id != null)
                    siNode.Elements("Id").SingleOrDefault().Value = siModel.Id;
                    if (siModel.Japanese != null)
                    siNode.Elements("Japanese").SingleOrDefault().Value = siModel.Japanese;
                    if (siModel.Pronounce != null)
                    siNode.Elements("Pronounce").SingleOrDefault().Value = siModel.Pronounce;
                    if (siModel.Mean != null)
                    siNode.Elements("Mean").SingleOrDefault().Value = siModel.Mean;
                    if (siModel.Genre != null)
                    siNode.Elements("Genre").SingleOrDefault().Value = siModel.Genre;
                    siNode.Elements("Example").SingleOrDefault().Value = siModel.Example;
                    if (siModel.Speak!=null)
                    siNode.Elements("Speak").SingleOrDefault().Value = siModel.Speak;
                    siNode.Elements("Date").SingleOrDefault().Value = siModel.Date;
                    if (siModel.Picture != null)
                    siNode.Elements("Picture").SingleOrDefault().Value = siModel.Picture;
                  
                    doc.Save(Config.dataStoreFile);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }


            //Find
            public DataStoreModel Find(string Id)
            {
                var doc = XDocument.Load(Config.dataStoreFile);
                try
                {
                    var note = (from c in doc.Descendants("Entity")
                                where c.Element("Id").Value == Id
                                select new DataStoreModel
                                {

                                    Id = (string)c.Element("Id") != null ? (string)c.Element("Id").Value : "",
                                    Japanese = (string)c.Element("Japanese") != null ? (string)c.Element("Japanese").Value : "",
                                    Pronounce = (string)c.Element("Pronounce") != null ? (string)c.Element("Pronounce").Value : "",
                                    Mean = (string)c.Element("Mean") != null ? (string)c.Element("Mean").Value : "",
                                    Genre = (string)c.Element("Genre") != null ? (string)c.Element("Genre").Value : "",
                                    Example = (string)c.Element("Example") != null ? (string)c.Element("Example").Value : "",
                                    Speak = (string)c.Element("Speak") != null ? (string)c.Element("Speak").Value : "",
                                    Date = (string)c.Element("Date") != null ? (string)c.Element("Date").Value : "",
                                    Picture = (string)c.Element("Picture") != null ? (string)c.Element("Picture").Value : ""
           
                                }
                                ).SingleOrDefault();
                    return note;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            //Find All
            public List<DataStoreModel> FindAll(string strJapanese)
            {
                var doc = XDocument.Load(Config.dataStoreFile);
                try
                {
                    var note = (from c in doc.Descendants("Entity")
                                where c.Element("Japanese").Value.Contains(strJapanese)
                                select new DataStoreModel
                                {
                                    Id = (string)c.Element("Id") != null ? (string)c.Element("Id").Value : "",
                                    Japanese = (string)c.Element("Japanese") != null ? (string)c.Element("Japanese").Value : "",
                                    Pronounce = (string)c.Element("Pronounce") != null ? (string)c.Element("Pronounce").Value : "",
                                    Mean = (string)c.Element("Mean") != null ? (string)c.Element("Mean").Value : "",
                                    Genre = (string)c.Element("Genre") != null ? (string)c.Element("Genre").Value : "",
                                    Example = (string)c.Element("Example") != null ? (string)c.Element("Example").Value : "",
                                    Speak = (string)c.Element("Speak") != null ? (string)c.Element("Speak").Value : "",
                                    Date = (string)c.Element("Date") != null ? (string)c.Element("Date").Value : "",
                                    Picture = (string)c.Element("Picture") != null ? (string)c.Element("Picture").Value : ""
                                }
                                ).ToList();
                    return note;
                }
                catch (Exception)
                {
                    return null;
                }
            }

        }
}
