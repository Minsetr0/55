int allPictures = 52;
int picturesInRow = 3;
int filledRows = 52 / 3;
int remainingPictures = allPictures % picturesInRow;
Console.WriteLine("Заполненных рядов:" + filledRows);
Console.WriteLine("Картинки сверх меры" + remainingPictures);