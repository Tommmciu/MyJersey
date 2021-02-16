using System.Collections.Generic;
using System.Linq;
using System.Windows.Media.Imaging;
using MyJersey.Entities;
using MyJersey.GUI.Extensions;

namespace MyJersey.GUI.ViewModels
{
    public class JerseyViewModel
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public BitmapImage Photo { get; set; }
        public JerseyViewModel(string name, string team, byte[] photo = null)
        {
            Name = name;
            Team = team;
            Photo = photo?.LoadImage();
        }

        public JerseyViewModel(Jersey jersey) : this(jersey.Name, jersey.Team.Name,
            jersey.Photos?.FirstOrDefault()?.Data)
        {
        }

    }
}