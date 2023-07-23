namespace Battleships_game {
    class Ship
    {
        public static IDictionary<int, string> ShipsToCreate = new Dictionary<int, string> { 
            {5, "Carrier"}, 
            {4, "Battleship"}, 
            {3, "Criuser"},
            {2, "Destroyer"}, 
            {2, "Destroyer2"}, 
            {1, "Submarine"}, 
            {1, "Submarine2"}
        };
        public static int GetShipSize(int Index) {
            return ShipsToCreate[Index][0];
        }
        public Ship(string ShipName, int ShipSize)
        {
            Name = ShipName;
            Size = ShipSize;
        }
        public string Name = "";
        public int Size = 0;
        public static void PlaceRandomShips()
        {

            // randomowe rozmieszcznie statkow na planszy dla przeciwnika
        }

        internal static void PlacePieceByCordinates((int row, int col) value)
        {
            throw new NotImplementedException();
        }
    }
}

// Statki: 
 
// 1 statek typu "Carrier" (zwany również "Lotniskowcem") o długości 5 pól
// 1 statek typu "Battleship" (znany również jako "Pancernik") o długości 4 pól
// 1 statek typu "Cruiser" (nazywany również "Krążownikiem") o długości 3 pól
// 2 statki typu "Destroyer" (nazywane również "Niszczycielami") o długości 2 pól każdy
// 2 statki typu "Submarine" (zwane również "Okrętami podwodnymi") o długości 1 pola każdy