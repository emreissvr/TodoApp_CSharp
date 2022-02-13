using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoProject
{
    class Todo
    {
        private string _title;
        private string _content;
        private int _memberID;
        private int _duration;
        private int _status;

        public Todo(string title, string content, int duration, int member_id = 1, int status = 0)
        {
            this._title = title;
            this._content = content;
            this._duration = duration;
            this._memberID = member_id;
            this._status = status;

        }

        public string GetTitle()
        {
            return this._title;
        }
        public string GetContent()
        {
            return this._content;
        }
        public string GetMember()
        {
            if (this._memberID == 1) { return "emre işsever"; }
            else if (this._memberID == 2) { return "kemal yıkılmaz"; }
            else if (this._memberID == 3) { return "cemre soylu"; }
            else if (this._memberID == 4) { return "beyza dağlı"; }
            else
            {
                return "Atanan yok.";
            }
        }
        public string GetDuration()
        {
            string duration = Enum.GetName(typeof(Duration), this._duration);
            return duration;
        }
        public int GetStatus()
        {
            return this._status;
        }



        public void SetTitle(string value)
        {
            this._title = value;
        }
        public void SetContent(string value)
        {
            this._content = value;
        }
        public void SetMember(int value)
        {
            this._memberID = value;
        }
        public void SetDuration(int value)
        {
            this._duration = value;
        }
        public void SetStatus(int value)
        {
            if (value == 0 || value == 1 || value == 2)
            {
                this._status = value;
            }
            else
            {
                throw new Exception("Todo durumu 0(TODO), 1(IN PROGRESS) ya da 2(DONE) olabilir.");
            }

        }
        public void TodoDetails()
        {
            Console.WriteLine("Başlık      :" + GetTitle());
            Console.WriteLine("İçerik      :" + GetContent());
            Console.WriteLine("Atanan Kişi :" + GetMember());
            Console.WriteLine("Büyüklük    :" + GetDuration());
        }
    }
}
