FROM node:14-alpine as builder

COPY package.json package-lock.json ./

## Storing node modules on a separate layer will prevent unnecessary npm installs at each build
RUN npm i && mkdir /vue-app && cp -R ./node_modules ./vue-app

WORKDIR /vue-app

COPY . .

## Build the angular app in production mode and store the artifacts in dist folder
RUN npm run build


FROM nginx:1.18-alpine

## Remove default nginx website
RUN rm -rf /usr/share/nginx/html/*

## From 'builder' stage copy over the artifacts in dist folder to default nginx public folder
COPY --from=builder /vue-app/dist /usr/share/nginx/html

CMD ["nginx", "-g", "daemon off;"]