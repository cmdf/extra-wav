Play PCM WAV audio in Windows Console.
> 1. Download [exe file](https://raw.githubusercontent.com/winp/extra-bel/master/ecd.cmd).
> 2. Copy to `C:\Program_Files\Scripts`.
> 3. Add `C:\Program_Files\Scripts` to `PATH` environment variable.


```batch
> ewav [-i|--input <input wav file>]

:: [] -> optional argument
:: <> -> argument value
```

```batch
:: play council.wav file
> ewav --input council.wav

:: play council.wav, using stdin
> cat council.wav | ewav
```
