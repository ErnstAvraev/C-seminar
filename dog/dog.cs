int distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
int count = 0;
while (distance > 10)
{
    int time1 = distance / (firstFriendSpeed + dogSpeed);
    int time2 = distance / (secondFriendSpeed + dogSpeed);
    if (friend == 1)
    {
        distance = distance - (firstFriendSpeed + secondFriendSpeed) * time1;
        count++;
    }
    if (friend == 2)
    {
        distance = distance - (firstFriendSpeed + secondFriendSpeed) * time2;
        count++;
    }
}
Console.Write($"Собака пробежит {count} раз.");
