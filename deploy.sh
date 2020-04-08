docker build -t CapstoneProject-image .

docker tag CapstoneProject-image registry.heroku.com/CapstoneProject/web


docker push registry.heroku.com/CapstoneProject/web

heroku container:release web -a CapstoneProject