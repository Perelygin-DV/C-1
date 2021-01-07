using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace HW8
{
	class TrueFalse
	{
		string fileName;
		List<Question> list;
		Stack<Question> stack = new Stack<Question>();

		private bool answer;
		
		
		Random rnd = new Random();


		public string FileName
		{
			set { fileName = value; }
			get{ return fileName; }
		}

		public TrueFalse(string fileName)
		{
			this.fileName = fileName;
			list = new List<Question>();
			//list = Convert();
		}

		public void Add(string text,bool trueFalse)
		{
			list.Add(new Question(text, trueFalse));
		}

		public void Remove(int index)
		{
			if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
		}

		public Question this[int index]
		{
			get { return list[index]; }
		}


		//Сохранение в XML
		public void Save(string path)
		{
			XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
			Stream fStream = new FileStream(path, FileMode.Create, FileAccess.Write);
			xmlFormat.Serialize(fStream, list);
			fStream.Close();
		}

		//Загрузка в XML
		public void Load()
		{
			//XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
			//Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			//list=(List<Question>)xmlFormat.Deserialize(fStream);
			//fStream.Close();

			//public List<Question> LoadXML()
			
			string base1 = File.ReadAllText(fileName);
			//List<Question> list = new List<Question>();

			var col = XDocument.Parse(base1).
									 Descendants("ArrayOfQuestion").
									 Descendants("Question").
									 ToList<XElement>();
			foreach (var item in col)
			{
				list.Add(new Question()
				{
					text = item.Element("text").Value,
					trueFalse = bool.Parse(item.Element("trueFalse").Value)

				}
				);
			}


		}



			

		public int Count
		{
			get { return list.Count; }
		}

		//преобразование из CSV в LIST

		public void Convert()
		{
			List<Question> tmp = new List<Question>();

			StreamReader str = new StreamReader(fileName,Encoding.Default);

			string [] st = new string[2];
			while (!str.EndOfStream)
			{
				st = str.ReadLine().Split(new char[] { ';' });
				
				tmp.Add(
					new Question
					{
						text = st[0],
						trueFalse=st[1]=="1"
						
					}) ;
			}

			str.Close();

			list = tmp;

			//XElement QS = new XElement("main");

			//foreach(var e in tmp)
			//{
			//	XElement Task = new XElement("task");
			//	XElement question = new XElement("question");
			//	question.Value = e.text;
			//	XElement answer = new XElement("answer");
			//	answer.Value = e.trueFalse.ToString();
			//	Task.Add(question, answer);
			//	QS.Add(Task);

			//}

			//QS.Save(outputF+".XML");

			//return tmp;


		}

		//получили вопрос

		public string GetQuestion()
		{
			if (list.Count==0) { return "Откройте или создайте базу вопросов"; }
			else
			{
				Question tmp;
				do
				{
					tmp = list[rnd.Next(0, this.Count)];
				}

				while (stack.Contains(list[rnd.Next(0, Count - 1)]));
				stack.Push(tmp);
				answer = tmp.trueFalse;
				return tmp.text;
			}
		}

		//проверка правильности ответа
		public bool Check(bool checkbox)
		{			
			if (answer == checkbox) return true;
			else return false;
		}

		public void CleanStack()
		{
			stack.Clear();
		}




	





		//	}
		//}


	}
}
