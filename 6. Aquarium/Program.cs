int lenghtCm = int.Parse(Console.ReadLine());
int widthCm = int.Parse(Console.ReadLine());
int heightCm = int.Parse(Console.ReadLine());
double percentNonWaterFill = double.Parse(Console.ReadLine());

int aquariumVolumeCm = lenghtCm * widthCm * heightCm;
double aquariumVolumeLtrs = aquariumVolumeCm / 1000.0;
double occupiedSpace = percentNonWaterFill / 100;
double litersToFillAquarium = aquariumVolumeLtrs * (1 - occupiedSpace);

Console.WriteLine($"{litersToFillAquarium:F2}");
