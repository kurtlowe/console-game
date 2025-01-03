var greeting = new Dialog(); // Calling and instance of a method from a different class
greeting.DialogWelcomeText();

var map = new MapManager();
map.Map1Generator();

greeting.DialogPlayerName();

var app = new MainGameLoop();
app.GameLoop(map);
