var str1="10 20 100 1000 5000";
var str1="Os1 Os12 Os123 Os123Os Os12312Os123";
var invalidEmail = 'Osama@@@gff...com';
var validEmail = 'o@nn.sa';
var ip ='19.168.2.1';
var url='elzero.org';
var url='elzero.org/'

/*

new RegExp("Pattern","modifiers")

modifiers

i => case-insensetive
g => global
m => multilines

Match
-- matches A string against a regular expression pattern
-- returns an array with matches
-- returns null if no match is found 

Ranges

(x|y) => x or y
[0-9] => 0 to 9
[^0-9] => Anything Except 0 to 9

[a-z]
[^a-z]
[A-Z]
[^A-Z]
[abc]
[^abc]

character classes
.  => matches any character except newline or termination charaters
\w =>matches word characters [a-z,A-z,0-9 and _ ]
\W => matches non word characters
\d => matches digits 0 to 9
\D => matches non digit characters
\s => matches white space character
\S => matchws non white space character

\b => matches at the beginning or end of word
\B => matches NOT at the beginning or end of word

test method

*/ 
var tld = "com nwt org info code io"
var inputMail="ahmed225@gmail.com@GMAIL.com";
var regex = /(org|info|io)/i;

var nums ="12345678910"
var numsRe=/[0-9]/g;
console.log(nums.match(numsRe))

var specialnums ="1!2@3$4%5^6&7*8910"
var specialnumsRe=/[^0-9]/g;
console.log(specialnums.match(specialnumsRe))

var practice ="Os1 Os1Os Os2 Os8 Os8Os"
var practiceRe=/os[5-9]os/ig;
console.log(practice.match(practiceRe))

var sstr = "AaBbCdefG123!234%^&*";
var atozsmall = /[a-z]/g;
var notatozsmall = /[^a-z]/g;
console.log(sstr.match(atozsmall));


var email = '123@fg.com O@@@g...com o@g.com o@g.net A@Y.com o-g.com o@s.org 1@1.com'
var mailregex = /\w@\w.(com|org)/g
console.log(email.match(mailregex));

var names = "sayed 1Spam 2Spam 3Spam 4Spam Spam5 Osama Ahmed"
var spammers = /(\bspam|spam\b)/ig
console.log(names.match(spammers));


var mails = "valid@example.com, user.name@domain.com, user123@sub.domain.org, valid_email@xyz.io, valid-email@abc.co.uk, invalid@@example.com, user@.com, @nodomain.com, user@domain, user@domain..com, user@domain.c, user@-domain.com, user@domain_com, user@domain@another.com, .user@domain.com, user@domain.com., user@do..main.com"
var mailregexX = /[A-Za-z].+@\w+.com/g;
console.log("SSSS");
console.log(mails.match(mailregexX));



/[a-zA-z]{1,}\w+@\w+.com/