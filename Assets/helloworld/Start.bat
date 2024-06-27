cd Assets
cd helloworld
cd src
del main.leo.meta

cd ..
leo run > %~dp0\outputs\Output.txt
