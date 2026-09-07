interface IProtectiveItem
{
    int protection{ get; set; }
    string name {get; set; }

    int Protect(int incomingDamage);
}

