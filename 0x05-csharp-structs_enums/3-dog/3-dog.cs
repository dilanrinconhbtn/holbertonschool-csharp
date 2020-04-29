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

    public override string ToString()
    {
        return string.Format("Dog Name: {0}\nAge: {1}\nOwner: {2}\nRating: {3}", name, age, owner, rating);
    }
}
