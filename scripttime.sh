#!usr/local/bin/bash

echo "Running scripttime.sh"

filename="./Dateis$(date +'%Y%m%d').txt"
timestamp=$(date +"%Y-%m-%d:%T")

echo ${timestamp}

touch ${filename}

if [[ -e ${filename} ]]; then
    echo "File Exists new login at ${timestamp}" >> ./${filename}

else 
    echo "First Run today! at ${timestamp}" >> ./${filename}
fi

echo "Done"
