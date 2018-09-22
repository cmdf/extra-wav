Play PCM WAV audio in Windows Console.
> 1. Download [exe file](https://github.com/winp/extra-wav/releases/download/1.0.0/ewav.exe).
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


[![Merferry](https://i.imgur.com/TcEJvcR.jpg)](https://merferry.github.io)
