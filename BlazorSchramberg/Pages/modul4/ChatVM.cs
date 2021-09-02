using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSchramberg.Pages.modul4
{

    public class ChatVM
    {
        public Action onAdd;

        public List<Nachricht> ChatListe { get; set; } = new List<Nachricht>();
        public void Add(string msg)
        {

            ChatListe.Add(new Nachricht { Text = msg });
            onAdd?.Invoke();
        }

    }
}
