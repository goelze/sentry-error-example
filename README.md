`SENTRY_DSN` will need to be configured.

`/` will succeed and return a view.  
`/Home/Test` will throw an exception.

The exception logged to Sentry shows the transaction as `GET /Errors/Index/{id?}` instead of `GET /Home/Test/{id?}`, as seen below:

![screenshot of Sentry error](sentry_error_screenshot.png)