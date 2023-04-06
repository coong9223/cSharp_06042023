using BanGiay_ASP_c4.Models;

namespace BanGiay_ASP_c4.iServices
{
    public interface iColor
    {
        public bool createColor(Color c);
        public bool updateColor(Color c);
        public bool deleteColor(Guid id);
        public List<Color> getAllColor();
        public Color getById(Guid idColor);
        public List<Color> getByName(string name);
    }
}
