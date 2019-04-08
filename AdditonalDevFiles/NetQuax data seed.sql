use NetQuax

TRUNCATE TABLE ADDRESSES
TRUNCATE TABLE USERS
TRUNCATE TABLE CREDITCARD
TRUNCATE TABLE MOVIES
TRUNCATE TABLE USERTYPES


INSERT INTO ADDRESSES VALUES ('4 Blueberry Lane', 'Line 2', 'Danielson', 'Connecticut', 06239, 1)
INSERT INTO USERS VALUES ('Andrew', 'Andrew', 1, 1, 1, 1)
INSERT INTO CREDITCARD VALUES ('1234-1234-1234-1234', GETDATE(), 'VISA', 1, 1)
INSERT INTO MOVIES VALUES ('Raiders of the Lost Ark', 'Harrison Ford is a badass','Steven Spielberg', 'Adventure', 'Harrison Ford', 1981, 4, 'HD', 12.50, 1)
INSERT INTO USERTYPES VALUES ('Little Duckling', 2)
INSERT INTO USERTYPES VALUES ('Full-Grown Duck', 5)
INSERT INTO USERTYPES VALUES ('Mother Duck', 10)

INSERT INTO MOVIES VALUES ('The Grinch', 'Christmas Spirit does not need presents', 'Ron Howard', 'Comedy', 'Jim Carrey', 2000, 8, 'HD', 6.50, 2)

INSERT INTO MOVIES VALUES ('Idiocracy', 'Society has dumbed down', 'Mike Judge', 'Comedy', 'Luke Wilson', 2006, 6, 'SD', 3.99, 0)

INSERT INTO MOVIES VALUES ('Snakes on a plane', 'Plane is full of poisonous snakes', 'David Ellis', 'Adventure', 'Samual Jackson', 2006, 5, 'SD', 4.99, 1)

INSERT INTO MOVIES VALUES ('American Hustle', 'Crime involved with Mafia and FBI', 'David Russell', 'Drama', 'Jennifer Lawrence', 2013, 6, 'HD', 2.99, 2)

INSERT INTO MOVIES VALUES ('How To Train Your Dragon', 'humans have awesome dragon pets', 'Dean DeBlois', 'Adventure', 'Jay Baruchel', 2019, 8, 'HD', 5.50, 0)

INSERT INTO MOVIES VALUES ('Dr. Strangelove', 'An insane general triggers a path to nuclear holocaust that a War Room full of politicians and generals frantically tries to stop, Stanley Kubrick', 'Comedy', 'Peter Sellers', 1964, 8, 'PG', 'SD', 5.99, 1 )

INSERT INTO MOVIES VALUES ('Psycho', 'A Phoenix secretary embezzles forty thousand dollars from her employers client, goes on the run, and checks into a remote motel run by a young man under the domination of his mother', 'Alfred Hitchcock', 'Horror', 'Anthony Perkins', 1960, 6, 'SD', 3.99, 1 )

INSERT INTO MOVIES VALUES ('The Apartment', 'A man tries to rise in his company by letting its executives use his apartment for trysts, but complications and a romance of his own ensue', 'Billy Wilder', 'Comedy', 'Jack Lemmon', 1960, 8, 'HD', 5.99, 1 )

/*INSERT INTO MOVIES VALUES ('The Godfather', 'The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son', 'Francis Ford Coppola', 'Crime', 'Drama', 'Marlon Brando', 1972, 6, 'HD', 5.99, 2 )*/

INSERT INTO MOVIES VALUES ('Jaws', 'When a killer shark unleashes chaos on a beach resort, its up to a local sheriff, a marine biologist, and an old seafarer to hunt the beast down', 'Steven Spielberg', 'Adventure', 'Roy Scheider', 1975, 9, 'SD', 4.50, 1)

/*INSERT INTO MOVIES VALUES ('Taxi Driver, A mentally unstable veteran works as a nighttime taxi driver in New York City, where the perceived decadence and sleaze fuels his urge for violent action by attempting to liberate a presidential campaign worker and an underage prostitute', 'Martin Scorsese', 'Drama', 'Diahnne Abbott',  1976, 6, 'SD', 2.99, 0 )*/

INSERT INTO MOVIES VALUES ('Rocky',' A small-time boxer gets a supremely rare chance to fight a heavy-weight champion in a bout in which he strives to go the distance for his self-respect', 'John G. Avildsen', 'Drama', 'Sylvester Stallone', 1976, 6, 'SD', 3.50, 0 )

INSERT INTO MOVIES VALUES ('The Deer Hunter', 'An in-depth examination of the ways in which the U.S. Vietnam War impacts and disrupts the lives of people in a small industrial town in Pennsylvania', 'Michael Cimino', 'Drama', 'Robert De Niro', 1978, 6, 'HD', 4.99, 2)

INSERT INTO MOVIES VALUES ('Alien', 'After a space merchant vessel perceives an unknown transmission as a distress call, its landing on the source moon finds one of the crew attacked by a mysterious life form, and they soon realize that its life cycle has merely begun', 'Ridley Scott', 'Sci-Fi', 'Tom Skerritt', 1998, 8, 'HD', 5.99, 2)

/*INSERT INTO MOVIES VALUES ('Saturday Night Fever', 'Anxious about his future after high school, a 19 year old Italian American from Brooklyn tries to escape the harsh reality of his bleak family life by dominating the dance floor at the local disco', 'John Badham', 'Drama', 'Music', 'John Travolta', 1977, 9, 'SD', 5.99, 2)*/

INSERT INTO MOVIES VALUES ('The Terminator', 'A seemingly indestructible android is sent from 2029 to 1984 to assassinate a waitress, whose unborn son will lead humanity in a war against the machines, while a soldier from that war is sent to protect her at all costs', 'James Cameron','Sci-Fi', 'Arnold Schwarzenegger', 1984, 9, 'SD', 5.99, 0)

/*INSERT INTO MOVIES VALUES ('Back to the Future', 'Marty McFly', 'a 17-year-old high school student, is accidentally sent thirty years into the past in a time-traveling DeLorean invented by his close friend, the maverick scientist Doc Brown', 'Robert Zemeckis', 'Adventure', 'Michael J. Fox', 1985, 5, 'HD', 5.99, 2)*/

INSERT INTO MOVIES VALUES ('Top Gun', 'As students at the United States Navys elite fighter weapons school compete to be best in the class, one daring young pilot learns a few things from a civilian instructor that are not taught in the classroom', 'Tony Scott', 'Action','Tom Cruise', 1986, 6, 'HD', 5.99, 2)

INSERT INTO MOVIES VALUES ('Indiana Jones and the Raiders of the Lost Ark', 'In 1936, archaeologist and adventurer Indiana Jones is hired by the US government to find the Ark of the Covenant before Adolf Hitlers Nazis can obtain its awesome powers', 'Steven Spielberg', 'Action', 'Harrison Ford', 1981, 8.5, 'sd', 5.99, 1)

INSERT INTO MOVIES VALUES ('The Shining', 'A family heads to an isolated hotel for the winter where a sinister presence influences the father into violence, while his psychic son sees horrific forebodings from both past and future', 'Stanley Kubrick', 'Horror', 'Jack Nicholson', 1980, 8.4, 'HD', 5.99, 0)

INSERT INTO MOVIES VALUES ('Scarface', 'In Miami in 1980, a determined Cuban immigrant takes over a drug cartel and succumbs to greed', 'Brian De Palma', 'Drama', 'Al Pacino', 1983, 8.3, 'HD', 6.50, 0)

INSERT INTO MOVIES VALUES ('Home Alone', 'An eight-year-old troublemaker must protect his house from a pair of burglars when he is accidentally left home alone by his family during Christmas vacation', 'Chris Columbus', 'Comedy', 'Macaulay Culkin', 1990, 7.5, 'SD', 4.50, 0)

/*INSERT INTO MOVIES VALUES (Ghost, After a young man is murdered, his spirit stays behind to warn his lover of impending danger, with the help of a reluctant psychic, Jerry Zucker, Drama, Fantasy, Romance, Thriller, Patrick Swayze,  1990, 7.0, HD, 4.50, 1)

INSERT INTO MOVIES VALUES (Pretty Woman, A man in a legal but hurtful business needs an escort for some social events, and hires a beautiful prostitute he meets only to fall in love, Garry Marshall, Comedy, Romance, Richard Gere, 1990, 7.0, HD, 3.99, 2)

INSERT INTO MOVIES VALUES (Men at Work, Two garbage men uncover a conspiracy involving illegal toxic waste dumping and decide to bring the whole operation down, Emilio Estevez, Action, Charlie Sheen, 1990, 5.9, HD, 2.99, 2)


INSERT INTO MOVIES VALUES (Problem Child, A young boy is just short of a monster. He is adopted by a loving man and his wacky wife. The laughs keep coming as the boy pushes them to the limits., Dennis Dugan, Comedy, John Ritter, Jack Warden, Michael Oliver, Gilbert Gottfried, 1990, 5.3, HD, 5.99, 2)

INSERT INTO MOVIES VALUES (The Patriot, Peaceful farmer Benjamin Martin is driven to lead the Colonial Militia during the American Revolution when a sadistic British officer murders his son, Roland Emmerich, Action, Drama, History, Mel Gibson, 2000, 7.2, SD, 4.50, 1)

INSERT INTO MOVIES VALUES (Cast Away, A FedEx executive undergoes a physical and emotional transformation after crash landing on a deserted island., Robert Zemeckis, Adventure, Tom Hanks, 2000, 7.8, SD, 5.99, 0)

INSERT INTO MOVIES VALUES (Remember the Titans, The true story of a newly appointed African-American coach and his high school team on their first season as a racially integrated unit, Boaz Yakin, Drama, Denzel Washington, 2000, 7.8, HD, price, 1)

INSERT INTO MOVIES VALUES (Inception, A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO, Christopher Nolan, Adventure, Sci-Fi, 2010, 8.8, HD, 2.99, 0)

INSERT INTO MOVIES VALUES (Black Swan, A committed dancer struggles to maintain her sanity after winning the lead role in a production of Tchaikovsky's "Swan Lake", Darren Aronofsky, Drama, Natalie Portman, 2010, 8.0, HD, 2.99, 1)


INSERT INTO MOVIES VALUES (Tangled Ever After, Rapunzel and Flynn Rider have their wedding, but Pascal and Maximus must recover the rings they lose in mid-ceremony, Nathan Greno, Family, Mandy Moore, 2012, 7.7, SD, 7.99, 2)*/





