Overview
=======

The top level API the client will use is <code>RTRuleSet</code>. The client pass the source text and a list of rules to construct an instance of an RTRuleSet. Then use the ExecuteXXX method to do the conversion.

From the client's perspective a rule is represented by a serializable class called RuleData, which defines a rule.

A rule executes in three steps:
* Matching - the source text is transformed into a list of matches.
* Transforming - a match is transformed into a string.
* Merging - transformed strings are merged into 1 string.

Correspondingly a rule has 3 expressions:
	* MatchExpression - A regular expression used to grab data from the source text.
	* TemplateExpression - A piece of RT script used to transform a match to a string. 
	* MergeExpression - A piece of RT script used to merge transformed strings into a single string.

Rule Execution in Details
-----------
### Matching
Use a regular expression to produce a list of matches. then each match is converted into one or more RTMatch object.
On a high level, Matcher convert a string into a jagged array. 
An RTMatch object is a list of items.
There are two types RTMatch object:
- GroupRTMatch - A regex match is converted into a GroupRTMatch. Each group in the match becomes an item.
- CaptureRTMatch - A regex match is converted into a list of CaptureRTMatch. Each group in the match becomes a CaptureRTMatch. Each capture in the group becomes an item.

### Transforming
Transform a Match object (which is a group of items) into a String. 
The transformer takes the Match object and use the transform template to do the job. 
There are two type of transform templates:
- Functional - A LISP like expression language.
- Simple - nested function calls amid string literals.

### Merging
When all matches are transformed, they are merged back together by RTMerger. The merge expression is used for this purpose.


Rule Options
-----------
A rule supports the options below:


* MatchOptions.RegexOptions
	The regular expresion options. 





