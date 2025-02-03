namespace Ex_Quartos
{
    struct Pensionato
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int? Room { get; set; }

        public Pensionato(string? name, string? email, int? room)
        {
            Name = name;
            Email = email;
            Room = room;
        }

        public override string ToString()
        {
            return Room + ": " + Name + ", " + Email;
        }
    }
}

