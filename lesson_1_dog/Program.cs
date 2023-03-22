int count = 0;
int distanse = 10000;
int FirstFriendSpeed = 1;
int SecondFriendSpeed = 2;
int dogspeed = 5;
int friend = 2;
int time = 0;

while(distanse > 10)
{
    if(friend == 1)
    {
        time = distanse/(SecondFriendSpeed+dogspeed);
        friend = 1;
    }
    else
    {
        time = distanse/(FirstFriendSpeed+dogspeed);
        friend = 2;
    }

    distanse = distanse - (FirstFriendSpeed + SecondFriendSpeed) * time;
    count++;
}

Console.WriteLine(count);

