# Expect100ContinueRepro
Reproduction of the Kester 100-continue issue

# Instructions
Build and run the application. Navigate to swagger, upload a file that is >50MB to the endpoint a few times. Expect connection resets.
You can try adding Expect: 100-continue header using any HTTP client - issue still remains
