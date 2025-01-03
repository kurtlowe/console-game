Console.CursorVisible = false;

var greeting = new Dialog();
greeting.DialogWelcomeText();

var map = new MapManager();
map.Map1Generator();

greeting.DialogPlayerName();

var app = new MainGameLoop();
app.GameLoop(map);
