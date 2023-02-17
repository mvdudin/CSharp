// Написать программу для перевода римских чисел в десятичные арабские.

int ParseChar(char pChar)
{
    switch (pChar)
    {
        case 'I': return 1;
        case 'V': return 5;
        case 'X': return 10;
        case 'L': return 50;
        case 'C': return 100;
        case 'D': return 500;
        case 'M': return 1000;
        default: return 0;
    }
}

int RomeToDecimal(string pNumber)
{
    int i = 0;
    int vCur = 0;
    int vNext = 0;
    int vResult = 0;
    while (i < pNumber.Length)
    {
        vCur = ParseChar(pNumber[i]);
        if (i + 1 < pNumber.Length)
        {
            vNext = ParseChar(pNumber[i + 1]);
        }
        else
        {
            vNext = vCur;
        }

        if (vCur < vNext)
        {
            vResult = vResult + (vNext - vCur);
            i += 2;
        }
        else
        {
            vResult += vCur;
            i += 1;
        }
    }
    return vResult;
}

Console.Clear();
Console.WriteLine(RomeToDecimal("MMMD"));
