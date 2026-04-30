public struct CurrencyAmount
{
    private decimal amount;
    private string currency;

    public CurrencyAmount(decimal amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }

    // TODO: implement equality operators

    public static bool operator ==(CurrencyAmount left, CurrencyAmount right)
    {
        if (left.currency != right.currency)
            throw new ArgumentException("Currencies must match.");

        return left.amount == right.amount;
    }

    public static bool operator !=(CurrencyAmount left, CurrencyAmount right)
    {
        if (left.currency != right.currency)
            throw new ArgumentException("Currencies must match.");

        return left.amount != right.amount;
    }

    // TODO: implement comparison operators

    public static bool operator >(CurrencyAmount left, CurrencyAmount right)
    {
        if (left.currency != right.currency)
            throw new ArgumentException("Currencies must match.");

        return left.amount > right.amount;
    }

    public static bool operator <(CurrencyAmount left, CurrencyAmount right)
    {
        if (left.currency != right.currency)
            throw new ArgumentException("Currencies must match.");

        return left.amount < right.amount;
    }

    // TODO: implement arithmetic operators

    public static decimal operator +(CurrencyAmount left, CurrencyAmount right)
    {
        if (left.currency != right.currency)
            throw new ArgumentException("Currencies must match.");

        return left.amount + right.amount;
    }

    public static decimal operator -(CurrencyAmount left, CurrencyAmount right)
    {
        if (left.currency != right.currency)
            throw new ArgumentException("Currencies must match.");

        return left.amount - right.amount;
    }

    public static decimal operator *(CurrencyAmount left, CurrencyAmount right)
    {
        if (left.currency != right.currency)
            throw new ArgumentException("Currencies must match.");

        return left.amount * right.amount;
    }

    public static decimal operator /(CurrencyAmount left, CurrencyAmount right)
    {
        if (left.currency != right.currency)
            throw new ArgumentException("Currencies must match.");

        return left.amount / right.amount;
    }

    // TODO: implement type conversion operators

    public static explicit operator double(CurrencyAmount value) => (double)value.amount;

    public static implicit operator decimal(CurrencyAmount value) => value.amount;
}
