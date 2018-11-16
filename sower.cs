namespace Expload {

    using Pravda;
    using System;

    [Program]
    public class Sower {
    	// Вопрос - нужен ли этот Main?
        public static void Main() { }

        // Константыё
        private UInt32 MIN_AMOUNT = 0;
        private UInt32 MAX_AMOUNT = 100000;
        private UInt32 MAX_OPEN_GAMES = 3;
        private UInt32 MOVE_TIME_LIMIT = 0;
        private UInt32 WAIT_GAME_TIME_LIMIT = 1000; // 1000 секунд
        private double BID_THRESHOLD = 0.1; // 10% - может заменить на UInt32
        private double COMMISSION = 0.1; // 10%
        // Переменные

         public Mapping<UInt32, Bytes> Board1 = new Mapping<Bytes, Bytes>();
         public Mapping<UInt32, UInt32> Status = new Mapping<Bytes, UInt32>();
         public Mapping<UInt32, UInt32> Player1 = new Mapping<Bytes, UInt32>();
         public Mapping<UInt32, UInt32> Player2 = new Mapping<Bytes, UInt32>();
         public Mapping<UInt32, UInt32> Kubik1 = new Mapping<Bytes, UInt32>();
         public Mapping<UInt32, UInt32> Kubik2 = new Mapping<Bytes, UInt32>();

        // Игры


        // Конструктор
        public Sower(UInt32 min_amount, UInt32 max_amount, UInt32 max_open_games, UInt32 move_time_limit, 
        	UInt32 wait_game_time_limit, double bid_treshold, double commission) {

			MIN_AMOUNT = min_amount;
			MAX_AMOUNT = max_amount;
			MAX_OPEN_GAMES = max_open_games;
			MOVE_TIME_LIMIT = move_time_limit;
			WAIT_GAME_TIME_LIMIT = wait_game_time_limit;
			BID_THRESHOLD = bid_treshold; 
			COMMISSION = commission; 
        }

        // Присоединится к игре
        public int connect(UInt32 playerId, UInt32 amount) {
        	// Возможно, что playerId будет передаваться в теле конструктора...
        	// Возможно, что придется создавать токены, чтобы игроки не ходили друг за друга

        	// Проверить, что контракт зарегистрирован

        	return gameId; // возвращает идентификатор игры 
        }

        // Отключится от игры
        public void cancel(int gameId) {

        }

        // Набор функций для получения значений

        public int getStatus(int gameId) {}
        public int getPlayer1(int gameId) {}
        public int getPlayer2(int gameId) {}
        public int getBoard(int gameId) {}
        public int getKubik1(int gameId) {} // Можно объединить кубики в виде двухзначного числа
        public int getKubik2(int gameId) {}

        // Ход

        public bool move(int gameId, int x, int y, int w, int h ) {
        	// Можно не передавать w и h - так как это будут последние значения кубиков в игре

        	return success; // возвращает, правильный ли был ход
        }

        // Дополнительные методы

        public int availableGames (int amount) {

        	return numGames; // Числа доступных игр для игрока с такой ставкой
        }


        // Серия функция для сбора информации об игроке
        public int playerInfo(int playerId) {

        }


        // Проверка, что отправлено правильным игроком
        private void assertIsPlayer()
        {
            if (Info.Sender() != Info.ProgramAddress())
            {
                Error.Throw("Only owner of the program can do that.");
            }
        }

    }
}
        public Mapping<Bytes, UInt32> Balance = 
            new Mapping<Bytes, UInt32>();
