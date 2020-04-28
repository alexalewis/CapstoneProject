docker build -t endlesspawsibilities-image .

docker tag endlesspawsibilities-image registry.heroku.com/endlesspawsibilities/web


docker push registry.heroku.com/endlesspawsibilities/web

heroku container:release web -a endlesspawsibilities