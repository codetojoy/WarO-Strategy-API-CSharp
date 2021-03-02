#!/bin/bash

MODE=$1
curl -X GET "http://localhost:5000/waro/strategy?prize_card=10&max_card=12&mode=${MODE}&cards=4&cards=6&cards=2" | jq

