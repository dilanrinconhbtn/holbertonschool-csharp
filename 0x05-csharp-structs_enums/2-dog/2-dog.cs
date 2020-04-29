using System;

enum Rating
{
    Good, 
    Great, 
    Excellent
}
struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public Dog(string NAME, float AGE, string OWNER, Rating RATING)
    {
        name = NAME;
        age = AGE;
        owner = OWNER;
        rating = RATING;
    }
}
