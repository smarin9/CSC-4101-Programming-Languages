;; Store away the Scheme48 definitios of +, -, *, /, =, <
(define s48-+ +)
(define s48-- -)
(define s48-* *)
(define s48-/ /)
(define s48-= =)
(define s48-< <)

;; Define binary built-in functions from Project 2
(define (b+ x y) (s48-+ x y))
(define (b- x y) (s48-- x y))
(define (b* x y) (s48-* x y))
(define (b/ x y) (s48-/ x y))
(define (b= x y) (s48-= x y))
(define (b< x y) (s48-< x y))

;; n-ary minus
(define (- x . l)
  (b- x (apply s48-+ l)))
