/*
Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/

/*
Random random = new Random();
int current = random.Next(1, 11);

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/

/*
Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);
*/

/*
int healthHero = 10;
int healthMonster = 10;
int attackHeroDamage = 0;
int attackMonsterDamage = 0;
int heroLostAmountHealth = 0;
int monsterLostAmountHealth = 0;

Random rnd = new Random();

Console.WriteLine("Hero attack first");

do{

attackHeroDamage = rnd.Next(1,11);
attackMonsterDamage = rnd.Next(1,11);

monsterLostAmountHealth = attackHeroDamage;
healthMonster = healthMonster - monsterLostAmountHealth;

Console.WriteLine("Amount of health the monster lost:" + monsterLostAmountHealth.ToString());
Console.WriteLine("Remaining Monster health: " + healthMonster.ToString());

if(healthMonster > 0){
    heroLostAmountHealth = attackMonsterDamage;
    healthHero = healthHero - heroLostAmountHealth;

    Console.WriteLine("Amount of health the hero lost:" + heroLostAmountHealth.ToString());
    Console.WriteLine("Remaining Hero health: " + healthHero.ToString());
}

}while((healthMonster > 0) && (healthHero > 0));

if((healthMonster > 0) && (healthHero <= 0)){
    Console.WriteLine("Monster Win's");
}
if((healthHero > 0) && (healthMonster <= 0)){
    Console.WriteLine("Hero Win's");
}
*/




/*
bool validEntry = true;
int numericValue = 0;
string? readResult;
do
{
    Console.WriteLine("User digit an integer value between 5 and 10, press enter:");

    readResult = Console.ReadLine();
    int.TryParse(readResult, out numericValue);

    if (readResult is not null)
    {
        if (!(numericValue >= 5 && numericValue <= 10))
        {
            Console.WriteLine("Sorry, you entered an invalid number, please try again");
            Console.WriteLine("You entered with value " + readResult + ". Please enter a number between 5 and 10.");
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input value " + readResult + " has been accepted.");
            break;
        }
    }

} while (validEntry);
*/


/*
string? readKey;
bool bKey = true;

while (bKey)
{
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readKey = Console.ReadLine();

    if (readKey is not null)
    {
        readKey = readKey.Trim().ToLower();

        switch (readKey)
        {
            case "administrator":
                bKey = false;
                break;

            case "manager":
                bKey = false;
                break;

            case "user":
                bKey = false;
                break;

            default:
                bKey = true;
                break;
        }
    }
    else
    {
        bKey = false;
    }

    if (bKey)
        Console.WriteLine("The role name that you entered, '" + readKey + "' is not valid. Enter your role name (Administrator, Manager, or User).");
    else
    {
        Console.WriteLine("Your input value (" + readKey + ") has been accepted.");
        break;
    }
}
*/


