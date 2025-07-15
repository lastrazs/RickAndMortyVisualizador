namespace RickAndMortyVisualizador.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Species { get; set; }
        public string Gender { get; set; }
        public string Image { get; set; }

        //Puntaje Local
        public int Score { get; set; } = 0;
    }
}
