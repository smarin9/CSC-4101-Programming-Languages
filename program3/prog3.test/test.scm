;;; (test name exp)
;;;
;;;	name: a string that names the test case
;;;	exp:  a function call expression for running the test 
;;;
;;; Compares the value of exp in standard Scheme48 to the value of exp
;;; after loading the definitions of ini.scm.  The file undefine.scm defines
;;; all functions that will be defined in ini.scm to return 'undefined.
;;; It also undefines Scheme48 functions that should not be used in ini.scm.
;;; An error is reported if exp is not a function call.  In R5RS Scheme
;;; it is not possible to check whether the function is defined before
;;; trying to call it.
;;;
;;; Author: Gerald Baumgartner
;;; Date:   12/7/2015

(define (test name exp)
  (newline)
  (if (pair? exp)
      (let ((fun (car exp))
	    (equal? equal?))
	(if (symbol? fun)
	    (let ((orig (eval exp (interaction-environment))))
	      (eval '(load "undefine.scm") (interaction-environment))
	      (eval '(load "ini.scm") (interaction-environment))
	      (display name)
	      (let ((val (eval exp (interaction-environment))))
		(if (equal? orig val)
		    (display ": PASS")
		    (begin
		      (display ": FAIL: ")
		      (if (eq? val 'undefined)
			  (begin (write fun) (display " undefined"))
			  (begin (display "wrong value for ") (write exp)))
		      ))))
	    (display (string-append "ERROR: " name " not a function call"))))
      (display (string-append "ERROR: " name " not a function call")))
  (newline)
  (values))
