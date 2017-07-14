cd ../
iwr http://52.164.252.39/swagger/v1/swagger.json -o Bitcoint.Api.Client.json
autorest --input-file=Bitcoint.Api.Client.json --csharp --namespace=Bitcoint.Api.Client --output-folder=./